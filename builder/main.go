package main

import "fmt"

const (
    id = 1
    title = "Mail password"
    email = "john.doe@email.com"
    password = "password123"
    username = "johndoe"
    note = "Note"
)

func TestEntryBuilder() {
    entry := getBuiltEntry()
    entry.Print()

    if entry.GetId() != id {
        fmt.Println("IDs are not equal.")
    }

    if entry.GetTitle() != title {
        fmt.Println("Titles are not equal.")
    }

    if entry.GetEmail() != email {
        fmt.Println("Emails are not equal.")
    }

    if entry.GetPassword() != password {
        fmt.Println("Password are not equal.")
    }

    if entry.GetUsername() != username {
        fmt.Println("Usernames are not equal.")
    }

    if entry.GetNote() != note {
        fmt.Println("Notes are not equal.")
    }
}

func getBuiltEntry() IEntryDTO {
    entry := NewEntryDTOBuilder().
        Id(id).
        Title(title).
        Email(email).
        Password(password).
        Username(username).
        Note(note).
        Build()

    return entry
}


func main() {
    TestEntryBuilder()
}
