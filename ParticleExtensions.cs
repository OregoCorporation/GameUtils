using System.Collections;
using UnityEngine;

namespace GameElements
{
    public static class ParticleExtensions
    {
        public static IEnumerator PlayOneShot(this ParticleSystem particleSystem)
        {
            particleSystem.Play();
            yield return new WaitForSeconds(particleSystem.main.duration);
            particleSystem.Stop();
        }
    }
}