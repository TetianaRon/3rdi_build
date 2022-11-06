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

## Finsish UI Logic


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

