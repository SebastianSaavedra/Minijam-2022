using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{

    public enum Sound
    {
        Zumbido,

    }

    //private static Dictionary<Sound, float> soundTimerDictionary;
    private static GameObject oneShotGameObject;
    private static AudioSource oneShotAudioSource;
    public static float masterVolume;

    public static void Initialize()
    {
        //soundTimerDictionary = new Dictionary<Sound, float>();
        masterVolume = .5f;
    }

    public static void PlaySound(Sound sound, float destroyTime)
    {
        PlaySound(sound, Camera.main.transform.position, destroyTime);
    }

    public static void PlaySound(Sound sound, Vector3 position)
    {
        PlaySound(sound, position, GetAudioClip(sound).length);
    }

    public static void PlaySound(Sound sound, Vector3 position, float destroyTime)
    {
        if (CanPlaySound(sound))
        {
            GameObject soundGameObject = new GameObject("Sound");
            soundGameObject.transform.position = position;
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.clip = GetAudioClip(sound);
            audioSource.volume = masterVolume * GetSoundVolume(sound);
            audioSource.Play();

            Object.Destroy(soundGameObject, destroyTime);
        }
    }

    public static void PlaySoundLoop(Sound sound)
    {
        if (CanPlaySound(sound))
        {
            GameObject soundGameObject = new GameObject("Sound");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.clip = GetAudioClip(sound);
            audioSource.volume = masterVolume * GetSoundVolume(sound);
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public static void PlaySound(Sound sound)
    {
        if (CanPlaySound(sound))
        {
            if (oneShotGameObject == null)
            {
                oneShotGameObject = new GameObject("One Shot Sound");
                oneShotAudioSource = oneShotGameObject.AddComponent<AudioSource>();
            }
            oneShotAudioSource.volume = .5f * GetSoundVolume(sound);
            oneShotAudioSource.PlayOneShot(GetAudioClip(sound));
        }
    }
    public static void PlaySoundNotOneShot(Sound sound)
    {
        if (CanPlaySound(sound))
        {
            GameObject soundGameObject = new GameObject("Sound");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.clip = GetAudioClip(sound);
            audioSource.volume = masterVolume * GetSoundVolume(sound);
            audioSource.Play();
        }
    }

    private static bool CanPlaySound(Sound sound)
    {
        switch (sound)
        {
            default:
                return true;
        }
    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        return GetSoundAudioClip(sound).audioClip;
    }

    private static float GetSoundVolume(Sound sound)
    {
        return GetSoundAudioClip(sound).volumen;
    }

    private static GameAssets.SoundAudioClip GetSoundAudioClip(Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.audioClipsArray)
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip;
            }
        }
        Debug.LogError("Sonido " + sound + " no encontrado!");
        return null;
    }
}
