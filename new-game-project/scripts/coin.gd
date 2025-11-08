#extends Area2D
#
#@onready var game_manager: Node = %"game manager"
#@onready var animation_player: AnimationPlayer = $AnimationPlayer
#
#
#
#
#
#
#func _on_body_entered(body: Node2D) -> void:
	#game_manager.add_point()
	#animation_player.play("pickup")

extends Area2D

@onready var animation_player: AnimationPlayer = $AnimationPlayer

func _on_body_entered(body: Node2D) -> void:
	GameManager.add_point()
	animation_player.play("pickup")

	  
