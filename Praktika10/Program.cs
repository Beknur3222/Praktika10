using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika10
{
    interface IPart
    {
        void Build();
    }

    class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Фундамент построен");
        }
    }

    class Wall : IPart
    {
        public void Build()
        {
            Console.WriteLine("Стена построена");
        }
    }

    class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Дверь установлена");
        }
    }

    class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Окно установлено");
        }
    }

    class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Крыша установлена");
        }
    }

    interface IWorker
    {
        void Work(IPart part);
    }

    class Worker : IWorker
    {
        public void Work(IPart part)
        {
            part.Build();
        }
    }

    interface ITeamLeader
    {
        void Report(List<IPart> parts);
    }

    class TeamLeader : ITeamLeader
    {
        public void Report(List<IPart> parts)
        {
            Console.WriteLine("Отчет бригадира:");
            foreach (var part in parts)
            {
                part.Build();
            }
        }
    }

    class Team
    {
        private List<IPart> parts;

        public Team()
        {
            parts = new List<IPart>();
        }

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void StartBuilding()
        {
            foreach (var part in parts)
            {
                IWorker worker = new Worker();
                worker.Work(part);
            }

            ITeamLeader teamLeader = new TeamLeader();
            teamLeader.Report(parts);

            Console.WriteLine("Строительство дома завершено.");
        }
    }

    class House
    {
        static void Main()
        {
            Team team = new Team();

            team.AddPart(new Basement());
            team.AddPart(new Wall());
            team.AddPart(new Wall());
            team.AddPart(new Wall());
            team.AddPart(new Wall());
            team.AddPart(new Door());
            team.AddPart(new Window());
            team.AddPart(new Window());
            team.AddPart(new Window());
            team.AddPart(new Window());
            team.AddPart(new Roof());

            team.StartBuilding();
            Console.ReadKey();
        }
    }

}
