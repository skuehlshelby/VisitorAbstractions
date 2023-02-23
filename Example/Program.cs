using VisitorAbstractions;

namespace Example
{
    using MusicPlayerState = IVisitableExtended<Paused, Playing>;
    using StateFactory = VisitableFactory<Paused, Playing>;
    using StateTransition = IVisitorExtended<IVisitableExtended<Paused, Playing>, Paused, Playing>;

    internal class Program
    {
        static void Main(string[] _)
        {
            MusicPlayer musicPlayer= new MusicPlayer();

            musicPlayer.Play();
            musicPlayer.Play();
            musicPlayer.Pause();
            musicPlayer.Play();
            musicPlayer.Pause();
            musicPlayer.Pause();
            musicPlayer.Play();
        }
    }

    class MusicPlayer
    {
        MusicPlayerState state = StateFactory.CreateExtended(new Paused());

        public void Play()
        {
            Console.WriteLine($"Pressed {nameof(Play)}");
            state = state.Accept(new PlayAction());
        }

        private sealed class PlayAction : StateTransition
        {
            MusicPlayerState StateTransition.Visit(Paused instance)
            {
                Console.WriteLine($"Transitioning to {nameof(Playing)} state...");
                return StateFactory.CreateExtended(new Playing());
            }

            MusicPlayerState StateTransition.Visit(Playing instance)
            {
                Console.WriteLine("Already playing...");
                return StateFactory.CreateExtended(instance);
            }
        }

        public void Pause()
        {
            Console.WriteLine($"Pressed {nameof(Pause)}");
            state = state.Accept(new PauseAction());
        }

        private sealed class PauseAction : StateTransition
        {
            MusicPlayerState StateTransition.Visit(Paused instance)
            {
                Console.WriteLine("Already paused...");
                return StateFactory.CreateExtended(instance);
            }

            MusicPlayerState StateTransition.Visit(Playing instance)
            {
                Console.WriteLine($"Transitioning to {nameof(Paused)} state...");
                return StateFactory.CreateExtended(new Paused());
            }
        }
    }

    class Paused
    {

    }

    class Playing
    {

    }
}