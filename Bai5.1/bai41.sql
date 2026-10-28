/*
 Navicat MySQL Data Transfer

 Source Server         : bai41
 Source Server Type    : MySQL
 Source Server Version : 101116
 Source Host           : localhost:3306
 Source Schema         : bai41

 Target Server Type    : MySQL
 Target Server Version : 101116
 File Encoding         : 65001

 Date: 28/10/2026 19:20:33
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE,
  UNIQUE INDEX `Username`(`Username`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES (1, 'admin', '123456');
INSERT INTO `users` VALUES (2, 'user01', '123456');
INSERT INTO `users` VALUES (3, 'user02', 'abc123');

SET FOREIGN_KEY_CHECKS = 1;
