# Performance-Bounceback

**Developed by- Vidhur Voora**

** Performance-Bounceback** is a very interesting High Immersive VR project. 

It can be experienced using the **Oculus Rift with touch controllers**. 

The aim of the project is to apply learnings of various optimization techniques to improve performance 

The various optimizations done were
1) Enabled Static and Dynamic batching
2) Made all non movable objects static for static batching
3) Added rigid bodies to the  parent object of the moving trampolines
4) Set the physics update rate to 90 fps by setting the fixed timestep to 0.018
5) Set no gravity for rigidbodies which are moving
6) Various Code optimizations
  - Moved the initialization code from update to start method. Removed unused start methods
  - Removed Debug.Log
  - Refactored the logic to have the object pooling implemented correctly
 7) Lighting Optmizations
  - Set the lighting rendering path to Forward
  - Enable 8x MSAA
  - Used baked lighting
  - Set Light Probes over the scen
  8) Various shadow optimizations


**Technology Stack**
This project is built using Unity 2017.2.0f3 , Oculus Unity Utilities 1.19.0, Steam VR Unity plugin v1.2.2



