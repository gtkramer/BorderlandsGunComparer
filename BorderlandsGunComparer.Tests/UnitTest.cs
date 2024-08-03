using BorderlandsGunComparer.CLI;

namespace BorderlandsGunComparer.Tests
{
    [TestClass]
    public class GunTests
    {
        [TestMethod]
        public void BorderlandsGun_CorrectlyCalculatesAmmortizedDamagePerSecond()
        {
            float baseDamage = 10;
            float ammoPerShot = 1;
            float accuracy = 1;
            float handling = 1;
            float reloadTime = 2;
            float fireRate = 5;
            float magazineSize = 30;

            float expectedAmmortizedDPS = 37.5F;

            BorderlandsGun testGun = new(baseDamage, ammoPerShot, accuracy, handling, reloadTime, fireRate, magazineSize);
            float actualAmmortizedDPS = testGun.AmmortizedDamagePerSecond;

            Assert.AreEqual(expectedAmmortizedDPS, actualAmmortizedDPS, 0.01, "Calculated ammortized damage per second does not match the expected value.");
        }
    }
}
