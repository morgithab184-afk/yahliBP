using Godot;
using System;

public partial class Player : RigidBody2D
{
	private int jumpForce = 500;
	private int speed = 200;
	// Called when the node enters the scene tree for the first time.
	[Export] private RayCast2D _groundRay;
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		if (Input.IsActionPressed("player jump") && IsOnFloor())
		{
			ApplyImpulse(Vector2.Up * -jumpForce);
		}

		if (Input.IsActionPressed("player left"))
		{
			ApplyImpulse(Vector2.Left * -speed*(float)(delta));
		}
		
		
		if (Input.IsActionPressed("player right"))
		{
			ApplyImpulse(Vector2.Right * speed*(float)(delta));
		}
	}
	
	bool IsOnFloor()
	{
		return _groundRay.IsColliding();
	}
	
}
