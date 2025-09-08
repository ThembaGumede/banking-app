INSERT INTO public."Users" ("UserID", "FirstName", "LastName", "Email", "DOB", "Status")
VALUES
(1, 'John', 'Doe', 'john.doe@example.com', '1995-06-15', 'active'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '1998-02-20', 'active'),
(3, 'Mike', 'Brown', 'mike.brown@example.com', '1990-12-05', 'inactive');

SELECT * FROM public."Users"