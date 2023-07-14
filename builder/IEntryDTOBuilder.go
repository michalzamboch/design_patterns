package main

type IEntryDTOBuilder interface {
	Id(id int) IEntryDTOBuilder
	Title(title string) IEntryDTOBuilder
	Username(username string) IEntryDTOBuilder
	Web(web string) IEntryDTOBuilder
	Password(password string) IEntryDTOBuilder
	Email(email string) IEntryDTOBuilder
	Note(note string) IEntryDTOBuilder
	Build() IEntryDTO
}
