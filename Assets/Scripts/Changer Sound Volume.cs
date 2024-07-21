using UnityEngine;
using UnityEngine.Audio;

public class SoundLoudnessChanger : MonoBehaviour
{
    private const string MasterVolume = "MasterVolume";
    private const string MusicVolume = "MusicVolume";
    private const string EffectsVolume = "EffectsVolume";

    [SerializeField] private AudioMixerGroup _mixerMaster;

    private float _minValue;

    public void ChangeVolumeMaster(float volume)
    {
        _mixerMaster.audioMixer.SetFloat(MasterVolume, GetMinValue(volume) * 20);
    }

    public void ChangeVolumeMusic(float volume)
    {
        _mixerMaster.audioMixer.SetFloat(MusicVolume, GetMinValue(volume) * 20);
    }

    public void ChangeVolumeEffects(float volume)
    {
        _mixerMaster.audioMixer.SetFloat(EffectsVolume, GetMinValue(volume) * 20);
    }

    private float GetMinValue(float volume)
    {
       return _minValue = Mathf.Log10(Mathf.Clamp(volume, 0.00001f, 1f));
    }
}
