extends Node

signal score_changed(score: int, high_score: int)

var score: int = 0
var high_score: int = 0
const SAVE_FILE_PATH := "user://save_data.save"

func _ready() -> void:
	load_high_score()
	emit_signal("score_changed", score, high_score) # initial UI update

func add_point() -> void:
	score += 1
	if score > high_score:
		high_score = score
		save_high_score()
	emit_signal("score_changed", score, high_score)
	print("GameManager: Score =", score, "High Score =", high_score)

# --- Save / Load High Score ---
func save_high_score() -> void:
	var file = FileAccess.open(SAVE_FILE_PATH, FileAccess.WRITE)
	if file:
		var data = {"high_score": high_score}
		file.store_string(JSON.stringify(data))
		file.close()

func load_high_score() -> void:
	if not FileAccess.file_exists(SAVE_FILE_PATH):
		return
	var file = FileAccess.open(SAVE_FILE_PATH, FileAccess.READ)
	if file:
		var content = file.get_as_text()
		var parsed = JSON.parse_string(content)
		if typeof(parsed) == TYPE_DICTIONARY and parsed.has("high_score"):
			high_score = parsed["high_score"]
		file.close()
