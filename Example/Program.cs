using Scott.Abstractions.VisitorPattern;

namespace Example
{
    using PlayState = IVisitable<Paused, Playing>;
    using PlayStateFactory = Visitable<Paused, Playing>;
    using PlayStateTransition = IFunctionVisitor2x2<IVisitable<Paused, Playing>, Paused, Playing, Locked, Unlocked>;
    using LockState = IVisitable<Locked, Unlocked>;
    using LockStateFactory = Visitable<Locked, Unlocked>;
    using LockStateTransition = IFunctionVisitor<IVisitable<Locked, Unlocked>, Locked, Unlocked>;

    internal class Program
    {
        static void Main(string[] _)
        {
            MusicPlayer musicPlayer= new MusicPlayer();

            musicPlayer.Play();
            musicPlayer.Play();
            musicPlayer.Pause();
            musicPlayer.PlaySong("Baby One More Time");
            musicPlayer.Lock();
            musicPlayer.PlaySong("All The Small Things");
            musicPlayer.Lock();
            musicPlayer.Play();
            musicPlayer.Pause();
            musicPlayer.Unlock();
            musicPlayer.Play();
            musicPlayer.PlaySong("Blood Sugar Sex Magik");
            musicPlayer.Unlock();
            musicPlayer.Pause();
            musicPlayer.Play();
        }
    }

    internal sealed class MusicPlayer
    {
        PlayState playState = PlayStateFactory.Create(new Paused(string.Empty));
        LockState lockState = LockStateFactory.Create(new Unlocked());

        public void Play()
        {
            playState = Visitors.Visit(new PlayAction(), playState, lockState);
        }

        public void Pause()
        {
            playState = Visitors.Visit(new PauseAction(), playState, lockState);
        }

        public void Lock()
        {
            lockState = lockState.Accept(new LockAction());
        }

        public void Unlock()
        {
            lockState = lockState.Accept(new UnlockAction());
        }

        public void PlaySong(string songName)
        {
            Visitors.Visit(new PlaySongAction(songName), playState, lockState);
        }

        private sealed class PlayAction : PlayStateTransition
        {
            public PlayState Visit(Paused left, Locked right)
            {
                Console.WriteLine($"Pressed '{nameof(Play)}' while '{nameof(Paused)}' and '{nameof(Locked)}'. Staying in '{nameof(Paused)}' state...");
                return PlayStateFactory.Create(left);
            }

            public PlayState Visit(Paused left, Unlocked right)
            {
                Console.WriteLine($"Pressed '{nameof(Play)}' while '{nameof(Paused)}' and '{nameof(Unlocked)}'. Transitioning to '{nameof(Playing)}' state...");
                return PlayStateFactory.Create(new Playing(left.Song));
            }

            public PlayState Visit(Playing left, Locked right)
            {
                Console.WriteLine($"Pressed '{nameof(Play)}' while '{nameof(Playing)}' and '{nameof(Locked)}'. Staying in '{nameof(Playing)}' state...");
                return PlayStateFactory.Create(left);
            }

            public PlayState Visit(Playing left, Unlocked right)
            {
                Console.WriteLine($"Pressed '{nameof(Play)}' while '{nameof(Playing)}' and '{nameof(Unlocked)}'. Staying in '{nameof(Playing)}' state...");
                return PlayStateFactory.Create(left);
            }
        }

        private sealed class PauseAction : PlayStateTransition
        {
            public PlayState Visit(Paused left, Locked right)
            {
                Console.WriteLine($"Pressed '{nameof(Pause)}' while '{nameof(Paused)}' and '{nameof(Locked)}'. Staying in '{nameof(Paused)}' state...");
                return PlayStateFactory.Create(left);
            }

            public PlayState Visit(Paused left, Unlocked right)
            {
                Console.WriteLine($"Pressed '{nameof(Pause)}' while '{nameof(Paused)}' and '{nameof(Unlocked)}'. Staying in '{nameof(Paused)}' state...");
                return PlayStateFactory.Create(left);
            }

            public PlayState Visit(Playing left, Locked right)
            {
                Console.WriteLine($"Pressed '{nameof(Pause)}' while '{nameof(Playing)}' and '{nameof(Locked)}'. Staying in '{nameof(Playing)}' state...");
                return PlayStateFactory.Create(left);
            }

            public PlayState Visit(Playing left, Unlocked right)
            {
                Console.WriteLine($"Pressed '{nameof(Pause)}' while '{nameof(Playing)}' and '{nameof(Unlocked)}'. Transitioning to '{nameof(Paused)}' state...");
                return PlayStateFactory.Create(new Paused(left.Song));
            }
        }

        private sealed class LockAction : LockStateTransition
        {
            public LockState Visit(Locked instance)
            {
                Console.WriteLine($"Pressed '{nameof(Lock)}' while '{nameof(Locked)}'. Staying in '{nameof(Locked)}' state...");
                return LockStateFactory.Create(instance);
            }

            public LockState Visit(Unlocked instance)
            {
                Console.WriteLine($"Pressed '{nameof(Lock)}' while '{nameof(Unlocked)}'. Transitioning to '{nameof(Locked)}' state...");
                return LockStateFactory.Create(new Locked());
            }
        }

        private sealed class UnlockAction : LockStateTransition
        {
            public LockState Visit(Locked instance)
            {
                Console.WriteLine($"Pressed '{nameof(Unlock)}' while '{nameof(Locked)}'. Transitioning to '{nameof(Unlocked)}' state...");
                return LockStateFactory.Create(new Unlocked());
            }

            public LockState Visit(Unlocked instance)
            {
                Console.WriteLine($"Pressed '{nameof(Unlock)}' while '{nameof(Unlocked)}'. Staying in '{nameof(Unlocked)}' state...");
                return LockStateFactory.Create(instance);
            }
        }

        private sealed class PlaySongAction : IActionVisitor2x2<Paused, Playing, Locked, Unlocked>
        {
            private readonly string songName;

            public PlaySongAction(string songName)
            {
                this.songName = songName;
            }

            public void Visit(Paused left, Locked right)
            {
                Console.WriteLine($"Tried to play song '{songName}', but player is locked. Continuing to play '{left.Song}'. ");
            }

            public void Visit(Paused left, Unlocked right)
            {
                Console.WriteLine($"Queueing up '{songName}'... ");
                left.Song = songName;
            }

            public void Visit(Playing left, Locked right)
            {
                Console.WriteLine($"Tried to play song '{songName}', but player is locked. Continuing to play '{left.Song}'. ");
            }

            public void Visit(Playing left, Unlocked right)
            {
                Console.WriteLine($"Playing '{songName}' instead of '{left.Song}'... ");
                left.Song = songName;
            }
        }
    }

    class Paused
    {
        public Paused(string song)
        {
            Song = song;
        }

        public string Song { get; set; }
    }

    class Playing
    {
        public Playing(string song)
        {
            Song = song;
        }

        public string Song { get; set; }
    }

    class Locked
    {

    }

    class Unlocked
    {

    }
}