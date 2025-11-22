# Marking Scheme
## 1. Physics (+40%)
### 1.1 Appropriate Use of Newtonian Physics (+7%)

- [ ] 1a) 1% — Usage of Rigid Bodies in Unity  
- [ ] 1b) 2% — Correct application of impulses in C#  
- [ ] 1c) Mass quantities:
- - [ ] 0% — All objects have same mass or none
- - [ ] 1% — Small variation in masses
- - [ ] 2% — Substantial variation in masses  


- [ ] 1d) 2% — Game mechanics are physics-driven (AI applies forces)

---

### 1.2 Advanced Physics (+8%)

- [x] 2a) 2% — Physics properties changed via scripts  
- [ ] 2b) 2% — Mass/physics as a gameplay mechanic  
- [x] 2c) Additional forces (projectiles, gravity, etc.):  
- - [ ] 1% — SUVAT used incorrectly
- - [x] 2% — Physically correct calculations


- [ ] 2d) 2% — AI calculates projectile forces  

---
### 1.3 Basic Collision Volumes (+5%)

- [x] 3a) 1% — At least one collision volume  
- [ ] 3b) 1% — More than one collision volume  
- [x] 3c) Collision volume matches mesh:  
- - [x]  1% — Sphere / Capsule / Box 
- - [ ] 2% — Mesh or Convex
- - [ ] 3% — Advanced (Terrain, Wheel)

---
### 1.4 Advanced Collision Volumes (+6%)

- [ ] 4a) 2% — A single GameObject has multiple colliders  
- [ ] 4b) 2% — Colliders enabled/disabled via scripts  
- [ ] 4c) 2% — Trigger volumes used in player mechanics  

---
### 1.5 Collision Response & Feedback (+7%)

- [ ] 5a) 1% — Realistic Rigidbody collision response  
- [ ] 5b) Use of OnCollision callbacks:  
- - [ ] +1% — OnCollisionEnter (2D)
- - [ ] +1% — OnCollisionExit (2D)
- - [ ] +1% — OnCollisionStay (2D)  


- [ ] 5c) Collision layers:  
- - [ ] +1% — Collision matrix modified
- - [ ] +1% — GameObjects use different layers  


- [ ] 5d) 1% — Physics materials used

---
### 1.6 Advanced Collision Response (+7%)

- [ ] 6a) 2% — Multiple physics materials  
- [ ] 6b) 2% — Runtime changes to physics materials  
- [ ] 6c) Trigger volumes trigger gameplay events:    
- - [ ] +1% — OnTriggerEnter (2D)
- - [ ] +1% — OnTriggerExit (2D)
- - [ ] +1% — OnTriggerStay (2D)

---
## 2. Graphics (+10%)
  ### 2.1 Graphical Elements (capped at +5%)

- [x] 7a) 2% — Multiple textures  
- [ ] 7b) 2% — Appropriate lighting  
- [x] 7c) 1% — Objects move/rotate via script  
- [x] 7d) 3% — Navigable 3D camera  
---
### 2.2 Advanced Graphics (+5%)

- [ ] 8a) +5% — Advanced graphics category  
- [ ] 8b) 1% — Infinite-looking environment (procedural tiling/pooling)  
- [ ] 8c) 1% — Realistic water  
- [ ] 8d) 1% — Scripted effects (weather, day/night)  
- [ ] 8e) 1% — Change object appearance via script  
- [ ] 8f) 1% — Changing geometry (e.g., plant growth)  
---
## 3. Pathfinding (+8%)

- [ ] 9a) NavMeshAgents:  

- - [ ] +0.5% — Used in Unity
- - [ ] +0.5% — Used in C#    

9b) NavMeshObstacles:  
- - [ ] +1% — Used in Unity
- - [ ] +1% — Used in C#  


- [ ] 9c) 3% — Custom or modified external pathfinding  
- [ ] 9d) 2% — AI decisions based on pathfinding  

---
## 4. Artificial Intelligence
###   4.1 State Machines (+10%)

(Scale — achieving a higher level grants lower levels automatically.)

- [ ] 10a) 4% — Simple state machines (booleans/enums)  
- [ ] 10b) 6% — States encapsulated in classes  
- [ ] 10c) 7% — Hierarchical state machines or external tools  
- [x] 10d) 8% — Triggered by external events/timeouts  
- [ ] 10e) 10% — Probabilistic/stochastic state transitions  
---
### 4.2 Advanced AI (≤12%)

- [ ] +3% — Planning (real planners)  
- [ ] +1% — GOAP  
- [ ] +3% — Non-cooperative game strategies (Min-Max, alpha-beta)  
- [ ] +5% — Reinforcement learning  
---
## 5. NPC Structuring (≤10%)

- [ ] 12a) 4% — NPCs act individually/reactively  
- [ ] 12b) 8% — NPCs coordinated as a group (manager, communication)  
- [ ] 12c) 10% — Orchestrator manages behaviours & events dynamically  
---
## 6. Advanced Features

### A1) Prefabs (+2%)  

- - [x]  +0.75% — PrefabInstance in scene
- - [x] +0.25% — Prefabs in project
- - [ ] +1% — Instantiate used in C#

### A2) Levels & Menus (+2%)
- - [ ] +1% — Multiple scenes/levels
- - [ ] +1% — Menu scene


- [ ] A3) +3% — Code limiting expensive operations (e.g., raycasting)
- [ ] A4) +2% — Flocking techniques
- [ ] A5) +2% — Vector fields
- [ ] A6) +2% — Particle systems
- [ ] A7) +2% — Custom AI tools (ExpectedMinMax etc.)