extends CanvasLayer

func show_game_over():
	visible = true

func _on_button_pressed():
	get_tree().paused = false
	get_tree().reload_current_scene()
