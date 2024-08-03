namespace BorderlandsGunComparer.CLI {
    public class BorderlandsGun {
        public float BaseDamage { get; }
        public float AmmoPerShot { get; }
        public float Accuracy { get; }
        public float Handling { get; }
        public float ReloadTime { get; }
        public float FireRate { get; }
        public float MagazineSize { get; }
        public float AmmortizedDamagePerSecond { get; private set; }

        public BorderlandsGun(float baseDamage, float ammoPerShot, float accuracy, float handling, float reloadTime, float fireRate, float magazineSize) {
            BaseDamage = baseDamage;
            AmmoPerShot = ammoPerShot;
            Accuracy = accuracy;
            Handling = handling;
            ReloadTime = reloadTime;
            FireRate = fireRate;
            MagazineSize = magazineSize;

            CalculateAmmortizedDamagePerSecond();
        }

        private void CalculateAmmortizedDamagePerSecond() {
            float damagePerSecond = BaseDamage * AmmoPerShot * Accuracy * FireRate;
            float shotsPerClip = MagazineSize / AmmoPerShot;
            float secondsPerClip = shotsPerClip / FireRate;
            float damagePerClip = damagePerSecond * secondsPerClip;
            float totalCycleTime = ReloadTime + secondsPerClip;
            AmmortizedDamagePerSecond = damagePerClip / totalCycleTime;
        }
    }
}
