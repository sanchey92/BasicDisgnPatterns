using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.State.SwitchBasedState
{
    public static class SwitchBasedStateSolution
    {
        public static void Run()
        {
            const string code = "1234";
            var state = LockState.Locked;
            var entry = new StringBuilder();
            var data = new Queue<int>(new[] {1, 2, 3, 4});

            while (true)
            {
                switch (state)
                {
                    case LockState.Locked:
                        var value = data.Dequeue();
                        Console.WriteLine(value);
                        entry.Append(value);
                        
                        if (entry.ToString() == code)
                        {
                            state = LockState.Unlocked;
                            goto case LockState.Unlocked;
                        }

                        if (!code.StartsWith(entry.ToString()))
                        {
                            state = LockState.Failed;
                        }

                        break;
                    case LockState.Failed:
                        Console.WriteLine("FAILED");
                        return;
                    case LockState.Unlocked:
                        Console.WriteLine("UNLOCKED");
                        return;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}