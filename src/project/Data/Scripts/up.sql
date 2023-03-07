-- CREATE DATABASE WatchParty

CREATE TABLE [Watcher] 
(
    [Id]                    INT                 NOT NULL PRIMARY KEY IDENTITY(1,1),
    [AspNetIdentityId]      NVARCHAR(450)       NOT NULL,
    [Username]              NVARCHAR(256)       NOT NULL,
    [FirstName]             NVARCHAR(64),
    [LastName]              NVARCHAR(64),
    [Email]                 NVARCHAR(256),
    [FollowingCount]        INT,
    [FollowerCount]         INT,
    [Bio]                   NVARCHAR(256)
);

CREATE TABLE [Post]
(
    [ID]                    INT                 NOT NULL PRIMARY KEY IDENTITY(1,1),
    [PostTitle]             NVARCHAR(2048)      NOT NULL,
    [PostDescription]       NVARCHAR(2048),
    [DatePosted]            DATETIME            NOT NULL,

    [UserID]                INT                 NOT NULL
);

CREATE TABLE [Reshare]
(
    [ID]                    INT                 NOT NULL PRIMARY KEY IDENTITY(1,1),
    
    [PostID]                INT                 NOT NULL,
    [UserID]                INT                 NOT NULL
);

CREATE TABLE [LikePost]
(
    [ID]                    INT                 NOT NULL PRIMARY KEY IDENTITY(1,1),

    [PostID]                INT                 NOT NULL,
    [UserID]                INT                 NOT NULL
);

CREATE TABLE [TopShow]
(
    [ID]                    INT                 NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Title]                 NVARCHAR(100)       NOT NULL,
    [UserId]                INT                 NOT NULL
);

CREATE TABLE [TopGenre]
(
    [ID]                    INT                 NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Genre]                 NVARCHAR(100)       NOT NULL,
    [UserId]                INT                 NOT NULL
);

ALTER TABLE [Post]                  ADD CONSTRAINT [Fk_Post_UserID]                 FOREIGN KEY([UserID])                   REFERENCES[Watcher]([Id])           ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE [Reshare]               ADD CONSTRAINT [Fk_Reshare_PostID]              FOREIGN KEY([PostID])                   REFERENCES[Post]([ID])              ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE [Reshare]               ADD CONSTRAINT [Fk_Reshare_UserID]              FOREIGN KEY([UserID])                   REFERENCES[Watcher]([ID])           ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE [LikePost]              ADD CONSTRAINT [Fk_LikePost_PostID]             FOREIGN KEY([PostID])                   REFERENCES[Post]([ID])              ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE [LikePost]              ADD CONSTRAINT [Fk_LikePost_UserID]             FOREIGN KEY([UserID])                   REFERENCES[Watcher]([ID])           ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE [TopShow]               ADD CONSTRAINT [Fk_TopShow_UserID]             FOREIGN KEY([UserID])                   REFERENCES[Watcher]([ID])           ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE [TopGenre]              ADD CONSTRAINT [Fk_TopGenre_UserID]            FOREIGN KEY([UserID])                   REFERENCES[Watcher]([ID])           ON DELETE NO ACTION ON UPDATE NO ACTION;
