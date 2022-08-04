#pragma once

#include <stdint.h>

const uint8_t approach_rate_signature[]      = { 0x8B, 0x85, 0xB0, 0xFE, 0xFF, 0xFF, 0xD9, 0x58, 0x2C };
const uint8_t circle_size_signature[]        = { 0x8B, 0x85, 0xB0, 0xFE, 0xFF, 0xFF, 0xD9, 0x58, 0x30 };
const uint8_t overall_difficulty_signature[] = { 0x8B, 0x85, 0xB0, 0xFE, 0xFF, 0xFF, 0xD9, 0x58, 0x38 };
const uint8_t current_scene_signature[]      = { 0xA1, 0xA3, 0xA1, 0xA3 };
const uint8_t beatmap_onload_signature[]     = { 0x8B, 0x86, 0x48, 0x01, 0x00, 0x00 };
const uint8_t selected_song_signature[]      = { 0xD9, 0xEE, 0xDD, 0x5C, 0x24, 0x10, 0x83, 0x3D };
const uint8_t audio_time_signature[]         = { 0xF7, 0xDA, 0x3B, 0xC2 };
const uint8_t osu_manager_signature[]        = { 0x33, 0xD2, 0x89, 0x15 };
const uint8_t binding_manager_signature[]    = { 0x8D, 0x45, 0xD8, 0x50, 0x8B, 0x0D };