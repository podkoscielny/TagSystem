# Multiple Tag System For Unity 
Is made to replace built in string based tag system. Easy to use, but very powerful.

## Navigation
* [Features](#features)
* [Setup Guide](#setup-guide)
* [Methods](#methods)
* [Performance Test](#performance-test)

## Features
- _**Multiple** tags for one GameObject_
- _More **performant** than built in tag system_
- _**Enum** based (forget about the strings)_
- _**Add** and **remove** tags at **runtime**_ 

## Setup Guide

### Installation
  Download the zip file and move TagSystem folder to your project 
  or download the unity package from the Release section and import it.
  
  ### Usage
  
  #### If you're using assembly definitions make sure to add _MultipleTagSystem.asmdef_ reference.
  <br />
  <img src="https://user-images.githubusercontent.com/49119130/165158167-e63e0665-02a9-4465-8743-619185aea56c.png" width="500" />
  
  ---
  
  #### Add any tag you would like to attach to GameObjects in **Tags** enum
  <br />
  <img src="https://user-images.githubusercontent.com/49119130/165154466-6a34232d-31b8-4189-8e7d-c7fb747ba17a.png" width="500" />
  
  ---
  
  #### Add **TagManager** to your GameObject
  <br />
  <img src="https://user-images.githubusercontent.com/49119130/165154917-86e042d7-a0d9-4eb1-b00f-29819f6d6a60.png" width="500" />
  
  ---

  #### Select Tags you would like to add
  <br />
  <img src="https://user-images.githubusercontent.com/49119130/165155104-21bc3e79-d2e1-4598-99f8-d8c0accc6aed.png" width="500" />
  
  #### And you are ready to go!


## Methods

Make sure to include `using AoOkami.MultipleTagSystem;` in your custom scripts.

### TagSystem.cs

#### *GameObject* FindGameObjectWithTag
Find one GameObject marked with specific tag\
<img src="https://user-images.githubusercontent.com/49119130/165166174-af8ebdbf-0924-47eb-9f1c-fe5ff88adf2d.png" width="650" />

#### *ReadOnlyCollection\<GameObject>* FindAllGameObjectsWithTag
Find all GameObjects marked with specific tag (returns ReadOnlyCollection)\
<img src="https://user-images.githubusercontent.com/49119130/165168290-9a6dea42-4f9a-48e0-95a6-f4585f5993af.png" width="650" />

### TagManager.cs

#### *bool* HasTag
Checks if TagManager attached to GameObject has specific tag. Returns true if it does.\
<img src="https://user-images.githubusercontent.com/49119130/165169825-685152ac-fabf-4e29-a57c-c549db799015.png" width="650" />

#### *void* AddTag
Add selected tag to TagManager.\
<img src="https://user-images.githubusercontent.com/49119130/165170870-6a406e55-0b59-4a96-9123-46ad9541d4ae.png" width="550" />

#### *void* RemoveTag
Remove selected tag from TagManager.\
<img src="https://user-images.githubusercontent.com/49119130/165170915-4be5bdeb-97c4-494e-b144-35227b8ef986.png" width="550" />

## Performance Test
Test performed at 100 000 iterations\
<img src="https://user-images.githubusercontent.com/49119130/165182402-9e3f3cd3-0343-4df9-8f8b-fb10d19ffa3f.png" width="550" />
