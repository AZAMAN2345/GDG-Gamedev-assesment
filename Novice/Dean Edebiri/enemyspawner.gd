extends Node
const enemy = preload("res://prefabs/enemy.tscn")
@export var spawn_area_width =2000.0
@export var spawn_height = -599
var camera_node: Camera2D = null
func _ready():
	$Timer.timeout.connect(_on_timer_timeout)
	$Timer.wait_time = 2
	$Timer.autostart = true
	camera_node = get_parent().find_child("Camera2d", true, false)
func _on_timer_timeout():
	self.spawn_enemy()
func spawn_enemy():
	var screen_left_x = 0
	if camera_node:
		screen_left_x = camera_node.global_position.x-(get_viewport().size.x/2)
		var new_enemy = enemy.instantiate()
		var random_x = randf_range(screen_left_x,screen_left_x+spawn_area_width)
		get_parent().add_child(new_enemy)
	var new_enemy = enemy.instantiate()
	var random_x = randf_range(0, spawn_area_width)
	new_enemy.global_position = Vector2(random_x, spawn_height)
	get_parent().add_child(new_enemy)
