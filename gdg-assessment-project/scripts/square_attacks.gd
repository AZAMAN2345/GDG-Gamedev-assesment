extends Area2D


@export var speed := 150.0
@export var spin := 180.0  # degrees per second

func _process(delta):
	# Move down
	position.y += speed * delta
	# Rotate while falling
	rotation_degrees += spin * delta

	# If it goes below the screen, remove it
	if position.y > get_viewport_rect().size.y + 50:
		queue_free()
