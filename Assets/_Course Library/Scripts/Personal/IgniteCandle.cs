using UnityEngine;

public class IgniteCandle : MonoBehaviour
{
    public ParticleSystem candleFlame; // Assign the candle flame particle system here
    public Light candleLight;
    public PlayContinuousSound fireSound;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object is the lighter's flame
        if (other.CompareTag("LighterFlame"))
        {
            // Start the candle flame particle system
            if (!candleFlame.isPlaying)
            {
                candleFlame.Play();
                fireSound.Play();
            }

            //Turn light on
            if (candleLight !=null && !candleLight.enabled)
            {
                candleLight.enabled = true;
            }
        }
    }
}