# ForgeFX-Test
unity project test for ForgeFX

Once you load up the scene, the following features have been implemented:

-A and D keys rotates the camera around the robot to view it from different angles.a
-mousing over the torso of the robot highlights the entire robot. when mousing over detachable limbs, said limbs highlight separate from torso. 
-left clicking and dragging on the torso moves the robot according to mouse position in world space.
-mousing over a detachable part brings up text feedback that tells user the limb's current status (ie. attached or detached)
-left clicking and dragging a limb will detach it from torso.
-when in close proximity to torso/limb area, able to reattach limb.
-unit test available for attached limbs, checks if detached boolean is set to false at start.
