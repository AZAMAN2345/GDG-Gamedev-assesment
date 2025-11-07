extends Node2D

@export var square_scene: PackedScene
@export var spawn_interval := 1.0  # seconds

var timer := 0.0

func _process(delta):
	timer += delta
	if timer >= spawn_interval:
		timer = 0
		spawn_square()

func spawn_square():
	var square = square_scene.instantiate()
	add_child(square)

	var screen_size = get_viewport_rect().size
	square.position = Vector2(randi_range(20, screen_size.x - 20), -20)
