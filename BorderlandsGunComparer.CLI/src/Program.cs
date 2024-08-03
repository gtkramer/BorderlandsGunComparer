namespace BorderlandsGunComparer.CLI {
    public class Program {
        public static void Main(string[] args) {
            var (baseDamage, ammoPerShot, accuracy, handling, reloadTime, fireRate, magazineSize) = GetParametersFromUser();
            BorderlandsGun gun = new(baseDamage, ammoPerShot, accuracy, handling, reloadTime, fireRate, magazineSize);
            Console.WriteLine("Ammortized damage per second: " + gun.AmmortizedDamagePerSecond.ToString("0.00"));
        }

        private static (float BaseDamage, float AmmoPerShot, float Accuracy, float Handling, float ReloadTime, float FireRate, float MagazineSize) GetParametersFromUser() {
            float baseDamage = GetFloatInput("Base damage: ");
            float ammoPerShot = GetFloatInput("Ammo per shot: ");
            float accuracy = GetFloatInput("Accuracy (%): ");
            float handling = GetFloatInput("Handling (%): ");
            float reloadTime = GetFloatInput("Reload time: ");
            float fireRate = GetFloatInput("Fire rate: ");
            float magazineSize = GetFloatInput("Magazine size: ");

            return (baseDamage, ammoPerShot, accuracy, handling, reloadTime, fireRate, magazineSize);
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
                    Console.Error.WriteLine("Invalid decimal");
                }
            }
            return value;
        }
    }
}
