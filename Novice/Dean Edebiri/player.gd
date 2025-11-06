extends CharacterBody2D
const GAME_OVER_SCENE = preload("res://gameover_screen.tscn")
const speed = 300.0
var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")

func _physics_process(delta):
	var input_direction = Input.get_vector("ui_left", "ui_right", "ui_up", "ui_down" )
	velocity.x = input_direction.x * speed
	if not is_on_floor():
		velocity.y += gravity * delta
		move_and_slide()
	move_and_slide()

func go_to_game_over():
	set_physics_process(false)
	set_process(false)
	get_tree().change_scene_to_file(GAME_OVER_SCENE.resource_path)
