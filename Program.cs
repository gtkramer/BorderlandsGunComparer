using System;
using System.IO;

namespace BorderlandsGunComparer
{
    class Program
    {
        public static void Main(string[] args)
        {
            float baseDamage = GetFloatInput("Base damange: ");
            float ammoPerShot = GetFloatInput("Ammo per shot: ");
            float accuracy = GetFloatInput("Accuracy (%): ") / 100;
            float handling = GetFloatInput("Handling (%): ") / 100;
            float reloadTime = GetFloatInput("Reload time: ");
            float fireRate = GetFloatInput("Fire rate: ");
            float magazineSize = GetFloatInput("Magazine size: ");

            float damagePerSecond = baseDamage * ammoPerShot * accuracy * fireRate;
            float shotsPerClip = magazineSize / ammoPerShot;
            float secondsPerClip = shotsPerClip / fireRate;
            float damagePerClip = damagePerSecond * secondsPerClip;
            float totalCycleTime = reloadTime + secondsPerClip;
            float ammortizedDamagePerSecond = damagePerClip / totalCycleTime;

            Console.WriteLine("Ammortized damage per second: " + ammortizedDamagePerSecond.ToString("0.00"));
        }

        private static float GetFloatInput(string prompt) {
            float value;
            while (true) {
                try {
                    Console.Write(prompt);
                    value = Convert.ToSingle(Console.ReadLine());
                    break;
                }
                catch {
                    TextWriter errorWriter = Console.Error;
                    errorWriter.WriteLine("Invalid decimal");
                }
            }
            return value;
        }
    }
}
