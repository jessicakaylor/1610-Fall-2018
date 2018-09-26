
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject
{
	public FloatData Data;
	
	public void OnPowerUp(FloatData outsidedData)
	{
		outsidedData.Value += Data.Value;
	}
}


	