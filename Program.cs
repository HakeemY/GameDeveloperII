// Create instances of the Melee, Ranged, and Magic Caster classes
Melee meleeEnemy = new Melee("MeleeEnemy");
Ranged rangedEnemy = new Ranged("RangedEnemy");
Magic magicEnemy = new Magic("MagicEnemy");

// Perform the Kick Attack from your Melee class character on your Ranged character
meleeEnemy.PerformAttack(rangedEnemy, new Attack("Kick", 15));

// Perform the Rage method from your Melee class character on your Magic Caster character
meleeEnemy.Rage();

// Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
rangedEnemy.PerformAttack(meleeEnemy, new Attack("Shoot an Arrow", 20));

// Have your Ranged character perform the Dash method
rangedEnemy.Dash();

// Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
rangedEnemy.PerformAttack(meleeEnemy, new Attack("Shoot an Arrow", 20));

// Perform a Fireball Attack from your Magic Caster on your Melee character
magicEnemy.PerformAttack(meleeEnemy, new Attack("Fireball", 25));

// Have the Magic Caster perform the Heal method on the Ranged character
magicEnemy.Heal(rangedEnemy);

// Have the Magic Caster perform the Heal method on themselves
magicEnemy.Heal(magicEnemy);