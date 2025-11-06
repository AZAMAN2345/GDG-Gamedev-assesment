extends Control
const GAME_SCENE = ("res://main.tscn")
func _on_button_pressed():
	get_tree().change_scene_to_file(GAME_SCENE)
