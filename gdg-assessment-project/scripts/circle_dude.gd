extends CharacterBody2D


@export var speed := 640

func _process(_delta):
	var direction := 0.0

	# Check left/right input
	if Input.is_action_pressed("ui_right"):
		direction = 1
	elif Input.is_action_pressed("ui_left"):
		direction = -1

	# Move the character
	velocity.x = direction * speed
	velocity.y = 0  # No up/down movement
	move_and_slide()

func _on_body_entered(area):
	if area.is_in_group("hazard"):
		game_over()


func game_over():
	get_tree().paused = true
	get_node("/root/Game/Game over screen").show_game_over()
