//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

[Serializable]
public class LoopTrack
{
	public AudioClip clip;
	[Range(0,1)]
	public float volume;

	public LoopTrack(LoopTrack other){
		clip = other.clip;
		volume = other.volume;
	}

}


