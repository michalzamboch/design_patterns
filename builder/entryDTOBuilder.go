package main

type entryBuilderDTO struct {
	id       int
	title    string
	username string
	web      string
	password string
	email    string
	note     string
}

func NewEntryDTOBuilder() IEntryDTOBuilder {
	return &entryBuilderDTO{}
}

func (builder *entryBuilderDTO) Id(id int) IEntryDTOBuilder {
	builder.id = id
	return builder
}

func (builder *entryBuilderDTO) Title(title string) IEntryDTOBuilder {
	builder.title = title
	return builder
}

func (builder *entryBuilderDTO) Username(username string) IEntryDTOBuilder {
	builder.username = username
	return builder
}

func (builder *entryBuilderDTO) Web(web string) IEntryDTOBuilder {
	builder.web = web
	return builder
}

func (builder *entryBuilderDTO) Password(password string) IEntryDTOBuilder {
	builder.password = password
	return builder
}

func (builder *entryBuilderDTO) Email(email string) IEntryDTOBuilder {
	builder.email = email
	return builder
}

func (builder *entryBuilderDTO) Note(note string) IEntryDTOBuilder {
	builder.note = note
	return builder
}

func (builder *entryBuilderDTO) Build() IEntryDTO {
	return &entryStructDTO{
		id:       builder.id,
		title:    builder.title,
		username: builder.username,
		web:      builder.web,
		password: builder.password,
		email:    builder.email,
		note:     builder.note,
	}
}
