# Marking Scheme
## 1. Physics (+40%)
### 1.1 Appropriate Use of Newtonian Physics (+7%)

- [x] 1a) 1% — Usage of Rigid Bodies in Unity  
    - **Bullet uses RigidBody (Prefabs>Bullet_Shotgun_A.prefab)**  
---
- [x] 1b) 2% — Correct application of impulses in C#
    - **Force is added to the bullet  (Scripts>Shotgun.cs)**
---
- [x] 1c) Mass quantities:
- - [ ] 0% — All objects have same mass or none
- - [x] 1% — Small variation in masses
  - **Bullet has a mass of 1, Enemy has a mass of 10 (Prefabs>Bullet_Shotgun_A.prefab, Prefabs>Enemy.prefab)**
- - [ ] 2% — Substantial variation in masses  
---
- [ ] 1d) 2% — Game mechanics are physics-driven (AI applies forces)
---
### 1.2 Advanced Physics (+8%)

- [x] 2a) 2% — Physics properties changed via scripts
    - **Player velocity changed  (Scripts>PlayerController.cs>HandleGroundedMovement())**
---
- [x] 2b) 2% — Mass/physics as a gameplay mechanic  
    - **A gun is used that uses physics to shoot bullets at enemies**
---
- [x] 2c) Additional forces (projectiles, gravity, etc.):  
- - [ ] 1% — SUVAT used incorrectly
- - [x] 2% — Physically correct calculations
  - **Gravity applied correctly using SUVAT (Scripts>PlayerController.cs>HandleVerticalMovement())** 
---
- [ ] 2d) 2% — AI calculates projectile forces
---
### 1.3 Basic Collision Volumes (+5%)

- [x] 3a) 1% — At least one collision volume  
    - **Enemy has a head collider and a body collider (Prefabs>Enemy.prefab)**
---
- [x] 3b) 1% — More than one collision volume 
  - **Enemy has a head collider and a body collider (Prefabs>Enemy.prefab)**
---
- [x] 3c) Collision volume matches mesh:  
- - [ ]  1% — Sphere / Capsule / Box 

- - [ ] 2% — Mesh or Convex
- - [x] 3% — Advanced (Terrain, Wheel)
  - **The mountain section at the end of the level is made using terrain tools**

---
### 1.4 Advanced Collision Volumes (+6%)

- [x] 4a) 2% — A single GameObject has multiple colliders  
  - **Enemy has a head collider and a body collider (Prefabs>Enemy.prefab)**
---
- [ ] 4b) 2% — Colliders enabled/disabled via scripts 
---
- [x] 4c) 2% — Trigger volumes used in player mechanics  
  - **Trigger volume is used to trigger snow particle system (SampleScene>TestLevel>Triggers>SnowTrigger)**

---
### 1.5 Collision Response & Feedback (+7%)

- [x] 5a) 1% — Realistic Rigidbody collision response  
  - **When the enemy is shot, it falls over from the force of the bullet.**
---
- [ ] 5b) Use of OnCollision callbacks:  
- - [ ] +1% — OnCollisionEnter (2D)
- - [ ] +1% — OnCollisionExit (2D)
- - [ ] +1% — OnCollisionStay (2D)  
---

- [ ] 5c) Collision layers:  
- - [x] +1% — Collision matrix modified
- - [x] +1% — GameObjects use different layers  
---

- [x] 5d) 1% — Physics materials used
    - **Mountain uses a slow physics material (Materials>PhysicsMaterials>SlowPhysicsMaterial.physicMaterial)**

---
### 1.6 Advanced Collision Response (+7%)

- [ ] 6a) 2% — Multiple physics materials  
  - **Multiple unique physics materials have been created (Materials>PhysicsMaterials)**
---
- [ ] 6b) 2% — Runtime changes to physics materials  
  - **Physics materials are configured at runtime (Scripts>PhysicsMaterialConfiguration.cs)**
---
- [ ] 6c) Trigger volumes trigger gameplay events:    
- - [ ] +1% — OnTriggerEnter (2D)
- - [ ] +1% — OnTriggerExit (2D)
- - [ ] +1% — OnTriggerStay (2D)

---
## 2. Graphics (+10%)
  ### 2.1 Graphical Elements (capped at +5%)

- [x] 7a) 2% — Multiple textures  
  - **Shotgun prefab and bullet prefab have different textures (Prefabs>Shotgun_E, Prefabs>Bullet_Shotgun_A)**
---
- [x] 7b) 2% — Appropriate lighting
  - **Directional Light GameObject used in scene**
---
- [x] 7c) 1% — Objects move/rotate via script
  - **Player rotation behaviour implemented (Scripts>CharacterController.cs)**
---
- [x] 7d) 3% — Navigable 3D camera  
  - **The 3D camera is fully navigable in game**
---
### 2.2 Advanced Graphics (+5%)

- [ ] 8a) +5% — Advanced graphics category  
---
- [ ] 8b) 1% — Infinite-looking environment (procedural tiling/pooling) 
---
- [x] 8c) 1% — Realistic water  
  - **Added water in the mountain section at the end of the level**
---
- [ ] 8d) 1% — Scripted effects (weather, day/night)  
---
- [ ] 8e) 1% — Change object appearance via script  
---
- [ ] 8f) 1% — Changing geometry (e.g., plant growth)  
---
## 3. Pathfinding (+8%)

- [ ] 9a) NavMeshAgents:  

- - [ ] +0.5% — Used in Unity
- - [ ] +0.5% — Used in C#    
---
9b) NavMeshObstacles:  
- - [ ] +1% — Used in Unity
- - [ ] +1% — Used in C#  
---

- [ ] 9c) 3% — Custom or modified external pathfinding  
- ---
- [ ] 9d) 2% — AI decisions based on pathfinding  

---
## 4. Artificial Intelligence
###   4.1 State Machines (+10%)

(Scale — achieving a higher level grants lower levels automatically.)

- [x] 10a) 4% — Simple state machines (booleans/enums)  
  - **Enum state code implemented (Scripts>PlayerController.cs>UpdateMovementState())**
---
- [ ] 10b) 6% — States encapsulated in classes  
---
- [ ] 10c) 7% — Hierarchical state machines or external tools  
---
- [ ] 10d) 8% — Triggered by external events/timeouts  
---
- [ ] 10e) 10% — Probabilistic/stochastic state transitions  
---
### 4.2 Advanced AI (≤12%)

- [ ] +3% — Planning (real planners)  
---
- [ ] +1% — GOAP  
---
- [ ] +3% — Non-cooperative game strategies (Min-Max, alpha-beta)  
---
- [ ] +5% — Reinforcement learning  
---
## 5. NPC Structuring (≤10%)

- [ ] 12a) 4% — NPCs act individually/reactively  
---
- [ ] 12b) 8% — NPCs coordinated as a group (manager, communication)  
---
- [ ] 12c) 10% — Orchestrator manages behaviours & events dynamically  
---
## 6. Advanced Features

### A1) Prefabs (+2%)  

- - [x]  +0.75% — PrefabInstance in scene
  - **Player prefab instanced in scene**
---
- - [x] +0.25% — Prefabs in project
  - **Prefab folder used (Prefabs)**
---
- - [x] +1% — Instantiate used in C#
  -   **Bullet instantiated (Scripts>Shotgun.cs)**
---

### A2) Levels & Menus (+2%)
- - [ ] +1% — Multiple scenes/levels
---
- - [ ] +1% — Menu scene
----


- [x] A3) +3% — Code limiting expensive operations (e.g., raycasting)
  - **Snow particle system is only activated when inside trigger volume (Scripts>SnowTrigger.cs)**
---
- [ ] A4) +2% — Flocking techniques
---
- [ ] A5) +2% — Vector fields
---
- [x] A6) +2% — Particle systems
  - **Added snow particle system at the end of the level**
---
- [ ] A7) +2% — Custom AI tools (ExpectedMinMax etc.)
---