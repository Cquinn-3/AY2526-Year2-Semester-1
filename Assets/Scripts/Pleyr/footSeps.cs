using UnityEngine;

public class footSeps : MonoBehaviour
{
    [Header("FootSteps")]
    [SerializeField] AudioClip[] footSteps;
    [SerializeField] AudioSource footStepSource;

    private void Start()
    {
        footStepSource = GetComponent<AudioSource>();
    }
    public void PlayFootSteps()
    {
        AudioClip clip;
        clip = footSteps[Random.Range(0, footSteps.Length)];
        footStepSource.clip = clip;
        footStepSource.volume = (Random.Range(0.5f, 06f));
        footStepSource.pitch = (Random.Range(0.8f, 1.2f));
        footStepSource.Play();
    }
}