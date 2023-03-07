ALTER TABLE [Post]                  DROP CONSTRAINT [Fk_Post_UserID]

ALTER TABLE [Reshare]               DROP CONSTRAINT [Fk_Reshare_PostID]
ALTER TABLE [Reshare]               DROP CONSTRAINT [Fk_Reshare_UserID]

ALTER TABLE [LikePost]              DROP CONSTRAINT [Fk_LikePost_PostID]
ALTER TABLE [LikePost]              DROP CONSTRAINT [Fk_LikePost_UserID]

ALTER TABLE [TopShow]               DROP CONSTRAINT [Fk_TopShow_UserID]
ALTER TABLE [TopGenre]               DROP CONSTRAINT [Fk_TopGenre_UserID]


DROP TABLE [Watcher];
DROP TABLE [Post];
DROP TABLE [Reshare];
DROP TABLE [LikePost];
DROP TABLE [TopShow];
DROP TABLE [TopGenre];

-- DROP DATABASE WatchParty;