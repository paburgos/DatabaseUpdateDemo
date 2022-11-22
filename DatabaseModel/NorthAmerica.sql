begin transaction

    IF NOT EXISTS(SELECT Country 
                  FROM Currency 
                  WHERE Country='Canada')
    BEGIN
        INSERT INTO Currency (NAME, COUNTRY, Abbreviation) VALUES ('CANADIAN DOLLAR', 'CANADA', 'CAD')
    END

    IF NOT EXISTS(SELECT Country 
                  FROM Currency 
                  WHERE Country='USA')
    BEGIN
        INSERT INTO Currency (NAME, COUNTRY, Abbreviation) VALUES ('US DOLLAR', 'USA', 'USD')
    END

    IF NOT EXISTS(SELECT Country 
                  FROM Currency 
                  WHERE Country='MEXICO')
    BEGIN
        INSERT INTO Currency (NAME, COUNTRY, Abbreviation) VALUES ('MEXICAN PESO', 'MEXICO', 'MXN')
    END

commit