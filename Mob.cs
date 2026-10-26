using Godot;
using System;

public partial class Mob : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D"); //animation list of animations names
		string[] mobTypes = animatedSprite2D.SpriteFrames.GetAnimationNames(); // return array containing all three animations
		animatedSprite2D.Play(mobTypes[GD.Randi() % mobTypes.Length]); //random number betwwen 0 and 2 to select one of these names from the list
	}

private void OnVisibleOnScreenNotifier2dScreenExited()
{
	QueueFree();
}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
