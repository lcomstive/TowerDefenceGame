using UnityEngine;

[CreateAssetMenu(fileName = "Turret", menuName = "Custom/Buildable/Turret")]
public class TurretData : BuildableData, IDamageDealer
{
	[Header("Turret Specific")]
	public GameObject BulletPrefab;

	[Tooltip("Shots per seconds")]
	public float FireRate = 2.0f;

	public float BulletVelocity = 10.0f;

	[Tooltip("Speed of rotation to aim at target")]
	public float RotationSpeed = 2.0f;

	[Tooltip("When true, only rotates on the Y axis")]
	public bool RestrictRotation = false;

	[field: SerializeField]
	public float Damage { get; private set; } = 1.0f;

	public int KillCount { get; set; } = 0;

	[Header("Element")]

	[Tooltip("Element to apply to an IModifierHolder if hit")]
	public Elements Element = Elements.Water;

	[Tooltip("How long to apply Element, in seconds")]
	public float ElementTime = 1.0f;
}