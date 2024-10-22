# AR Video Player Project

![ar1](https://github.com/user-attachments/assets/b3f9d7c8-58ed-4bbe-ba02-ea4509709b06)

## Overview
This project showcases an Augmented Reality (AR) experience using Unity and Vuforia. The application allows users to trigger video playback by interacting with a virtual button in the AR space. The video appears on a cube object, and the button also changes color based on the video's playback state (playing or paused).

## Features
- AR Interaction: Utilize Vuforia's virtual button technology to trigger actions in AR space.
- Video Playback: A video is played on a 3D cube when the virtual button is pressed.
- Dynamic Button Colors: The button changes its color depending on whether the video is playing (red) or paused (green).

## Project Structure
### 1. Video Cube:
- videocube1: A 3D cube in the AR environment that acts as the screen for the video.
- The VideoPlayer component attached to the cube handles video playback.
### 2. Virtual Button:
- VirtualButton1: A virtual button that the user interacts with to play or pause the video.
- The VirtualButtonBehaviour component triggers the assigned function when pressed.
### 3. Button Color:
- buttoncolor: A UI element or object in the AR space that changes color based on the state of the video (red for playing, green for paused).

## Code Explanation
### Script: functions.cs
- Initialization (Start() method):
  <br>
  - References the VideoPlayer component of the video cube.
  - Registers the function playvideo1() as a callback when the virtual button is pressed.
  <br>
- Video Playback Function (playvideo1()):
  <br>
  - Checks if the video is currently playing.
  - If not playing, starts the video and changes the button color to red.
  - If playing, pauses the video and changes the button color to green.
  <br>
## How It Works
- When the app detects the AR target, it loads the 3D cube in the AR space with the video content.
- Users can interact with the Virtual Button using their camera. Pressing the button toggles the video between play and pause.
- Depending on the video's state, the Button Color will dynamically change:
  - Red: Video is playing.
  - Green: Video is paused.

![ar2](https://github.com/user-attachments/assets/ec654351-195f-4bc4-8ace-1f06526790b4)
