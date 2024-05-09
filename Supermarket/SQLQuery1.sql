alter table Products add constraint FK_id_producer foreign  key (id_producer) references Producers(id_producer);
alter table Products add constraint FK_id_category foreign key (id_category) references Categories(id_category);
alter table Tickets add constraint FK_id_cashier foreign key (id_cashier) references Users(id_user);
alter table Stocks add constraint FK_id_product foreign key (id_product) references Products (id_product);
alter table Ticket_Products add constraint FK_id_ticket foreign key (id_ticket) references Tickets(id_ticket);
alter table Ticket_Products add constraint FK_id_product_2 foreign key (id_product) references Products(id_product);
