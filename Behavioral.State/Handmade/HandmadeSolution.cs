using System;
using System.Collections.Generic;

namespace Behavioral.State.Handmade
{
    public static class HandmadeSolution
    {
        private static Dictionary<StateEnum, List<(TriggerEnum, StateEnum)>> _rules =
            new Dictionary<StateEnum, List<(TriggerEnum, StateEnum)>>
            {
                [StateEnum.OffHook] = new List<(TriggerEnum, StateEnum)>
                {
                    (TriggerEnum.CallDialed, StateEnum.Connecting)
                },

                [StateEnum.Connecting] = new List<(TriggerEnum, StateEnum)>
                {
                    (TriggerEnum.HungUp, StateEnum.OnHook),
                    (TriggerEnum.CallConnected, StateEnum.Connected)
                },
                [StateEnum.Connected] = new List<(TriggerEnum, StateEnum)>
                {
                    (TriggerEnum.LeftMessage, StateEnum.OnHook),
                    (TriggerEnum.HungUp, StateEnum.OnHook),
                    (TriggerEnum.PlacedOnHold, StateEnum.OnHold)
                },
                [StateEnum.OnHold] = new List<(TriggerEnum, StateEnum)>
                {
                    (TriggerEnum.TakenOffHold, StateEnum.Connected),
                    (TriggerEnum.HungUp, StateEnum.OnHook)
                }
            };

        public static void Run()
        {
            StateEnum state = StateEnum.OffHook, exitState = StateEnum.OnHook;

            var queue = new Queue<int>(new[] {0, 1, 2, 0, 0});

            do
            {
                Console.WriteLine($"The phone is currently {state}");
                Console.WriteLine("Select a trigger: ");

                for (var i = 0; i < _rules[state].Count; i++)
                {
                    var (t, _) = _rules[state][i];
                    Console.WriteLine($"{i}. {t}");
                }

                var input = queue.Dequeue();
                Console.WriteLine(input);

                var (_, s) = _rules[state][input];
                state = s;
            } while (state != exitState);

            Console.WriteLine("We are done using the phone");
        }
    }
}