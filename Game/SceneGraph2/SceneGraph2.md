#  SceneGraph 2

The transform logic and the graph logic are both in the same class GameObject.
The components can implement any logic on top of the scene graph.

Surely, the most naive implementation... but still efficient.
The greatest problem is that the traversal of Components and GameObjects cannot be in another order.