package main

import (
	"fmt"
)

type entryStructDTO struct {
	id       int
	title    string
	username string
	web      string
	password string
	email    string
	note     string
}

func NewEntryDTO() IEntryDTO {
	return &entryStructDTO{}
}

func (dto *entryStructDTO) GetId() int {
	return dto.id
}

func (dto *entryStructDTO) GetTitle() string {
	return dto.title
}

func (dto *entryStructDTO) GetWeb() string {
	return dto.web
}

func (dto *entryStructDTO) GetUsername() string {
	return dto.username
}

func (dto *entryStructDTO) GetPassword() string {
	return dto.password
}

func (dto *entryStructDTO) GetEmail() string {
	return dto.email
}

func (dto *entryStructDTO) GetNote() string {
	return dto.note
}

func (dto *entryStructDTO) SetTitle(title string) {
	dto.title = title
}

func (dto *entryStructDTO) SetWeb(web string) {
	dto.web = web
}

func (dto *entryStructDTO) SetUsername(name string) {
	dto.username = name
}

func (dto *entryStructDTO) SetPassword(password string) {
	dto.password = password
}

func (dto *entryStructDTO) SetEmail(email string) {
	dto.email = email
}

func (dto *entryStructDTO) SetNote(note string) {
	dto.note = note
}

func (dto *entryStructDTO) ToString() string {
	return fmt.Sprintf("%d. \"%s\" %s %s %s %s \"%s\"",
		dto.id,
		dto.title,
		dto.username,
		dto.web,
		dto.password,
		dto.email,
		dto.note)
}

func (dto *entryStructDTO) Print() {
	fmt.Println(dto.ToString())
}
