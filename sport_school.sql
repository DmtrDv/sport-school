-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Ноя 24 2025 г., 21:51
-- Версия сервера: 5.7.25
-- Версия PHP: 7.1.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `sport_school`
--

-- --------------------------------------------------------

--
-- Структура таблицы `competitions`
--

CREATE TABLE `competitions` (
  `Id_competitions` int(11) DEFAULT NULL,
  `NameCompetitions` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Section` enum('Спортивный туризм','скалолазание','гребля') COLLATE utf8_bin DEFAULT NULL,
  `Date_Time_Conducting` datetime DEFAULT NULL,
  `Place_Conducting` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Id_instructor` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Id_Trainee` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Структура таблицы `instructor`
--

CREATE TABLE `instructor` (
  `Id_instructor` int(11) NOT NULL,
  `FIOInstructor` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `qualification` enum('Высшая','Первая','Вторая') COLLATE utf8_bin DEFAULT NULL,
  `NumberPhoneInstructor` varchar(11) COLLATE utf8_bin DEFAULT NULL,
  `Section` varchar(255) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Дамп данных таблицы `instructor`
--

INSERT INTO `instructor` (`Id_instructor`, `FIOInstructor`, `qualification`, `NumberPhoneInstructor`, `Section`) VALUES
(1, 'Иванов Иван Иванович', 'Первая', '78945612310', 'Спортивный_туризм');

-- --------------------------------------------------------

--
-- Структура таблицы `inventory`
--

CREATE TABLE `inventory` (
  `IdInventory` int(11) NOT NULL,
  `NameInventory` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `CountInventory` int(11) DEFAULT NULL,
  `DateDelivery` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Дамп данных таблицы `inventory`
--

INSERT INTO `inventory` (`IdInventory`, `NameInventory`, `CountInventory`, `DateDelivery`) VALUES
(1, 'Карабин (GURU)', 1202, '2025-11-19'),
(2, 'Карабин (Vento)', 121, '2025-11-23'),
(3, 'Восьмёрка (GURU)', 20, '2025-11-23');

-- --------------------------------------------------------

--
-- Структура таблицы `result`
--

CREATE TABLE `result` (
  `Id_result` int(11) DEFAULT NULL,
  `Id_competitions` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Id_Trainee` int(11) DEFAULT NULL,
  `Place` enum('1','2','3','нет') COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Структура таблицы `trainee`
--

CREATE TABLE `trainee` (
  `Id_Trainee` int(11) NOT NULL,
  `FIO` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `Section` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Category` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `FIOParent` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `PhoneNumberParent` varchar(11) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Дамп данных таблицы `trainee`
--

INSERT INTO `trainee` (`Id_Trainee`, `FIO`, `Birthday`, `Section`, `Category`, `FIOParent`, `PhoneNumberParent`) VALUES
(1, 'Петров Пётр Петрович', '1999-01-01', 'Спортивный туризм', 'I юношеский спортивный разряд', 'Петров Пётр Николаевич', '88005553535'),
(2, 'Иванов Иван Иванович', '2015-06-21', 'скалолазание', 'I_юношеский_спортивный_разряд', 'Иванов Иван Петрович', '79007009070'),
(3, 'Артёмов Артём Артёмович', '2007-02-08', 'гребля', 'отсутствует', 'Артёмов Артём Петрович', '99008007060'),
(4, 'Дмитров Дмитрий Дмитриевич', '2025-10-21', 'гребля', 'III_юношеский_спортивный_разряд', 'Дмитров Дмитрий Дмитриевич', '88888888888');

-- --------------------------------------------------------

--
-- Структура таблицы `written_off_inventory`
--

CREATE TABLE `written_off_inventory` (
  `IdWrittenOff` int(11) NOT NULL,
  `NameInventory` varchar(255) COLLATE utf8_bin NOT NULL,
  `CountWrittenOff` int(11) NOT NULL,
  `WriteOffDate` datetime NOT NULL,
  `OriginalInventoryId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Дамп данных таблицы `written_off_inventory`
--

INSERT INTO `written_off_inventory` (`IdWrittenOff`, `NameInventory`, `CountWrittenOff`, `WriteOffDate`, `OriginalInventoryId`) VALUES
(1, 'Карабин (GURU)', 10, '2025-11-24 23:37:01', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `instructor`
--
ALTER TABLE `instructor`
  ADD PRIMARY KEY (`Id_instructor`);

--
-- Индексы таблицы `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`IdInventory`);

--
-- Индексы таблицы `trainee`
--
ALTER TABLE `trainee`
  ADD PRIMARY KEY (`Id_Trainee`);

--
-- Индексы таблицы `written_off_inventory`
--
ALTER TABLE `written_off_inventory`
  ADD PRIMARY KEY (`IdWrittenOff`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `instructor`
--
ALTER TABLE `instructor`
  MODIFY `Id_instructor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `inventory`
--
ALTER TABLE `inventory`
  MODIFY `IdInventory` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `trainee`
--
ALTER TABLE `trainee`
  MODIFY `Id_Trainee` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `written_off_inventory`
--
ALTER TABLE `written_off_inventory`
  MODIFY `IdWrittenOff` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
