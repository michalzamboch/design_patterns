package main

type IEntryDTO interface {
	GetId() int

	GetTitle() string
	GetWeb() string
	GetUsername() string
	GetPassword() string
	GetEmail() string
	GetNote() string

	SetTitle(title string)
	SetWeb(web string)
	SetUsername(name string)
	SetPassword(password string)
	SetEmail(email string)
	SetNote(note string)

	ToString() string
	Print()
}
