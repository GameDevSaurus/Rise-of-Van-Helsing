using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyStates { Appearing, Taunting, Idle, Chasing, Fighting, Attack, Damaged, Dead };
public enum ZombieChaseAnimations { Slow1, Slow2, Slow3, Slow4, Fast1, Fast2, Fast3, Fast4 };
public enum NightmareChaseAnimations { walk };
public enum EnemyAttackTypes { Scratch, Bite, Hit };
public enum EnemyAttackParts { LeftHand, RightHand, Head };
public enum EnemyAttackDirections { Left2Right, Right2Left };
public enum EnemyType { CrawlingNightmare, WalkingNightmare, Zombie, SkeletonZombie, Troll, Werewolf, Explosive, Spitter, Bat, VampireGirl, Hulk }

public enum WeaponCategory {HandCrossbow, AutoCrossbow, HeavyCrossbow, DoubleGuns}

