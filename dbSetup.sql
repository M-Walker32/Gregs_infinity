CREATE TABLE IF NOT EXISTS accounts(
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    name varchar(255) COMMENT 'User Name',
    email varchar(255) COMMENT 'User Email',
    picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE cars(
    id INT NOT NULL AUTO_INCREMENT,
    make VARCHAR(255) NOT NULL,
    model VARCHAR(255) NOT NULL,
    imgUrl VARCHAR(255) NOT NULL,
    body VARCHAR(255) NOT NULL,
    price INT NOT NULL,
    userId VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE houses(
    id INT NOT NULL AUTO_INCREMENT,
    streetAddress VARCHAR(255) NOT NULL,
    imgUrl VARCHAR(255) NOT NULL,
    homedescription VARCHAR(255) NOT NULL,
    price INT NOT NULL,
    userId VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE jobs(
    id INT NOT NULL AUTO_INCREMENT,
    title VARCHAR(255) NOT NULL,
    pay INT NOT NULL,
    imgUrl VARCHAR(255) NOT NULL,
    jobDescription VARCHAR(255) NOT NULL,
    userId VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
)