/*
 * 
 * 
 * --- WATER ---
 *  - Is primarily used to amplify other elements (e.g. ice, electricity)
 *	- Removes 
 * 
 * 
 * 
 * 
 */

/// <see cref="Water"/>
///		- Is primarily used to amplify other elements (e.g. ice, electricity)
///		- Removes fire element
///	<see cref="Ice"/>
///		- Slows affected unit, this effect compounds
///		- Consumes water element
///	<see cref="Fire"/>
///		 - Applies damage to unit over time (tick-based)
///		 - Not applied to tick when ice is present, and removes it in place of water
///	<see cref="Acid"/>
///		- Increases damage affected unit takes
///		- Time applied is reduced by water being present
///	<see cref="Electricity"/>
///		- Halts unit for short period of time
///		- Time increased when water is present
///		- Cannot be applied to units with ice present
[System.Serializable]
public enum Elements
{
	/// <summary>
	/// It's wet.
	/// Increases effect of <see cref="Ice"/> & <see cref="Electricity"/>,
	/// but removes <see cref="Fire"/>
	/// </summary>
	Water,

	/// <summary>
	/// Reduces speed of a unit
	/// </summary>
	Ice,

	/// <summary>
	/// Inflicts damage to a unit over time
	/// </summary>
	Fire,

	/// <summary>
	/// Burns through armour, increasing damage from other units
	/// </summary>
	Acid,

	/// <summary>
	/// Halts unit for short period of time.
	/// Amplified by <see cref="Water"/> element.
	/// </summary>
	Electricity
}