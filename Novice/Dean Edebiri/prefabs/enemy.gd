extends CharacterBody2D
var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")
var SPEED = randf_range(1,200)
func _physics_process(_delta):
	velocity.y += gravity * _delta
	velocity.x = SPEED
	move_and_slide()
	if global_position.y > 1000: queue_free()

func _on_hitbox_body_entered(body):
	if body.name == "player":
		body.get_node("CollisionShape2D").set_disabled(true)
		body.get_node("AnimationPlayer").play("die")
		queue_free()
	pass # Replace with function body.
