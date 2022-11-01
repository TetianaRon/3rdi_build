# Technicla Task 

Target Platfrom: Oculus Quest 2

In the scene we have Peace of art.
After Interactivng with ART we Open flowing pannel.

![Visual](.\res\Build.gif)

## Srpint 8:00 AM

2 Clickable Object that changes Panel Content


## Guide

- [ ] Technical Task
- [ ] Plan
- [ ] Arcitecutre
- [ ] Test
- [ ] Implementation
- [ ] Visual

## Milesotone

07:00 We click on ojbect pannel apperars

## Todo 

- [ ] InteractableObject.cs 
    	even OnClicked()
- [ ] PanaleManager.cs
- [ ] MainPanel.cs


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

## Future

- [ ] ZenJeckt

## Log


> 10/30/22 06:26:16 AM

Start working

## Panel 

Panel is build out of 3 segments
- Segmaent A 
  always active.
- Segment B 
  is activated after interacting with interactible item.
- Segment C 
   is Dynamic segment it's activated after we interact with second segment.




## Architecture

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
~ 3-4 hour

## PoC Description


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

## Dealin

> 10/17/22 11:39:59 AM

till 2pm

```csharp 

```
