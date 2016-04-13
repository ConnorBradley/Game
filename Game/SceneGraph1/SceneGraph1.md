#  SceneGraph 1

The main goal is to separate the transform logic - in GameObject - from the tree logic - in Group.
The components can implement any logic on top of the scene graph.

The grouping of GameObjects is done with a component (Group).
Thus, the traversal of the scene tree may be done before, after or between calls to other components leading to greater flexibility.