# Technicla Task 

Target Platfrom: Oculus Quest 2

In the scene we have Peace of art.
After Interactivng with ART we Open flowing pannel.

![Visual](.\res\Build.gif)


## App Description


## PoC Description


## Panel 

Panel is build out of 3 segments
- Segmaent A 
  always active.
- Segment B 
  is activated after interacting with interactible item.
- Segment C 
   is Dynamic segment it's activated after we interact with second segment.

## Todo

- [ ] Make PoC
- [ ] Make Logic for The Segmented panel

- [ ] Add MRTK
- [ ] Add MRTK Examples
- [ ] Make MRTK Examples work with Quest 2
20 min

- [ ] Interactive Painting
- [ ] Iteractive Panel Segmant A
- [ ] Iteractive Panel Segmant B
- [ ] Iteractive Panel Segmant C

## Features


- [ ] Interactibale Objects
- [ ] Interactible menu

## Future

- [ ] ZenJeckt

## Maybe 

- Android AR
- Download another Dino
## Guide

- [x] Technical Task
- [ ] Plan
- [ ] Arcitecutre
- [ ] Test
- [ ] Implementation
- [ ] Visual

## Curse of action 

- Close Raj milestone. 



## Question


- What Raj wants?
    - Moving incide the space
    - MRTK Interactions
    - Photogronometry
    - Quizes -> Win -> Money
    - Metaverse Multiplyaer
    - He liked Dino Demo
    - Elite cars 
    - [HDRP Rooms Gallery](https://blog.unity.com/technology/explore-learn-and-create-with-the-new-hdrp-scene-template)



    - Mobile
    - Mobile VR
    - People who can't travel
    - For Hotels/Museum/Curorts/Univerity/Events
    - Blockchain/NFT's
    - AR painting real world recognition

- What could we show Raj to make him super happy:

    - Android build 
    - Android build for mobile VR
    - PC high quaility build with Photogenometry
    - UI panel pop-up
    - If he can see somebody walking near him.
    - Dino from portal
    - Dino in VR MUSIUM

### What we want:
	
- T:Super cool **UI PANELS WITH AWESOME ANIMATIONS**
    - With perfectly smooth animations

- T:High Quality Photogrometry museum walk.
- T:Show awesome donloaded models from Stock

- T: Loading Image sprites with HighQuality
- T: Panel tab switching
- T: Statue to move control scale e.t.c

- T: Scene Phtogrometry with one Button.
- T: Something with Yuriys Dinos
- T: Solar system with info
- T: Scene switching 

- Y: Oclus Quest 2 Build
- Y: Read MRTK documentation
- Y: MRTK Portal
- Y: MRTK Mars CAR
- Y: Quest with Hand controlling with MRTK
- Y: Reaseach and try Cool staff from MRTK and Oculus
- Y: Quest 2 Pianino
- Y: Quest 2 MRTK Passthrough + AR
- Y: Cinimamacine timeline DINO Demo


- Y: Ultra simple Multiplayer build for Raj walking in the same room Android
- Y: Oculus avatar something 
- Y: Research Meta Quest API


### Milestones to make Raj happy ASAP.

- What can we Record from Unity Screen To make Raj happy?

- What can we shoot while I am in Oculus And we see what is hapening?

- What Android build we can deliver raj?

- When I plan to finish it ?
- Who needs it ?
- What is target product?
- Who is target audience?
- What is tools we need to complete this task ? 
- What tools Tania lack



## Milesotone

- Milestone 01: Unity Screen Recording.
   - UI System  


- Milestone 02: Oculus build and video from it.

- Milestone 03: PC build for raj to try.

## Technical Task

Interactible Exponats UI Panel system 

	- Firstly for painingg

You walk around the room you see the paining on your focus(aiming) it react.

When we click on the button on controller or on InteractibleExponat in 2 m in 45 degree in fron of us pannel showes up

### Interactible Exonat

- Paintings:
    - OnFocus loads HIGH Quality

- ScriptedExponat
    - On Click Timeline starts
    - Sometimes there are no panel on it

- Interactible exponat 
    - You can drag and drop it and even physics works
    - Sometimes there are no panel on it

It Reacts on:

- Focus
- Click
- Ray 
- Hands
- OutOfFocus

### Tour Panel




## Todo 



## Architecture 

```csharp

class ExponatContent:ScriptbaleObject {

public string Name;
public Texture2D Icons;
public string Description;
public Action ObjecAction;
public Sprite[] Images;
public Audio[] Tracks;
public GameObject Prefab;
public ExponentContent[] RefContnet;

}

```

```csharp

class InteractibleObject{}

class GameManger{}

class PanelManger{}
class InteractbleManger{}
class MainPanel{}


```
### New Architect
```csharp
class GameManager{}
class PanelManager{}
class TourPanel{
	void SetTourObjectPanel(InteractiveTourObject obj){}
	void SetObjecInfoPanel(TourObjectInfo info)
}
class PanelElement{}
class InteractiveTourObject{
public TourObjectInfo[] tourObject(){}
	
}
class TourObject{}
```


> 10/30/22 06:26:16 AM

Start working


> 10/30/22 09:54:18 AM

Current task is to make 


> 11/04/22 10:03:06 PM

Although I made a lot now I am going back to work
