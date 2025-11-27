-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Ноя 27 2025 г., 22:25
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
  `NumberPhoneInstructor` varchar(17) COLLATE utf8_bin DEFAULT NULL,
  `Section` varchar(255) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Дамп данных таблицы `instructor`
--

INSERT INTO `instructor` (`Id_instructor`, `FIOInstructor`, `qualification`, `NumberPhoneInstructor`, `Section`) VALUES
(1, 'Иванов Иван Иванович', 'Первая', '+7(900)-788-68-78', 'Спортивный_туризм'),
(2, 'Полевой Виктор Павлович', 'Высшая', '+7(800)-505-23-31', 'Гребля'),
(3, 'Книжников Роман Александрович', 'Вторая', '+7(987)-978-55-66', 'Скалолазание'),
(4, 'Иванов Иван Иванович', 'Высшая', '+7(900)123-45-67', 'Спортивный_Туризм'),
(5, 'Петров Петр Сергеевич', 'Первая', '+7(900)234-56-78', 'Скалолазание'),
(6, 'Сидорова Анна Викторовна', 'Вторая', '+7(900)345-67-89', 'Гребля'),
(7, 'Козлов Дмитрий Олегович', 'Высшая', '+7(900)456-78-90', 'Гребля'),
(8, 'Николаева Елена Петровна', 'Первая', '+7(900)567-89-01', 'Спортивный_Туризм'),
(9, 'Орлов Алексей Игоревич', 'Вторая', '+7(900)678-90-12', 'Скалолазание'),
(10, 'Васильев Артем Дмитриевич', 'Высшая', '+7(900)789-01-23', 'Скалолазание');

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
(1, 'Карабин (GURU)', 5, '2025-11-27'),
(2, 'Восьмёрка (GURU)', 20, '2025-11-25'),
(4, 'Карабин (Vento)', 30, '2025-11-27'),
(5, 'Рюкзак туристический (Tramp)', 12, '2025-11-28'),
(6, 'Палатка 4-местная (RedFox)', 8, '2025-11-27'),
(7, 'Спальник трекинговый (Trekking)', 20, '2025-11-28'),
(8, 'Коврик туристический (Tramp)', 15, '2025-11-27'),
(9, 'Газовая горелка (RedFox)', 12, '2025-11-28'),
(10, 'Треккинговые палки (Trekking)', 18, '2025-11-25'),
(11, 'Компас спортивный (Tramp)', 10, '2025-11-28'),
(12, 'Фонарь налобный (RedFox)', 20, '2025-11-26'),
(13, 'Котел туристический (Trekking)', 8, '2025-11-28'),
(14, 'GPS-навигатор (Tramp)', 6, '2025-11-26'),
(15, 'Весло гоночное (Vento)', 30, '2025-11-25'),
(16, 'Спасательный жилет (AquaSport)', 25, '2025-11-28'),
(17, 'Байдарка туристическая (RiverPro)', 5, '2025-11-25'),
(18, 'Гермомешок (Vento)', 8, '2025-11-27'),
(19, 'Каска водная (AquaSport)', 15, '2025-11-25'),
(20, 'Гидрокостюм (RiverPro)', 12, '2025-11-25'),
(21, 'Сланцы для гребли (Vento)', 20, '2025-11-25'),
(22, 'Трос буксировочный (AquaSport)', 9, '2025-11-25'),
(23, 'Насос для лодки (RiverPro)', 6, '2025-11-27'),
(24, 'Ремкомплект для байдарки (Vento)', 8, '2025-11-27'),
(25, 'Страховочная система (GURU)', 18, '2025-11-28'),
(26, 'Каска скалолазная (ClimbPro)', 16, '2025-11-27'),
(27, 'Веревка основная 40м (RockMaster)', 9, '2025-11-28'),
(28, 'Оттяжки комплект (GURU)', 50, '2025-11-26'),
(29, 'Скальные туфли (ClimbPro)', 22, '2025-11-28'),
(30, 'Магнезия (RockMaster)', 10, '2025-11-26'),
(31, 'Жумар (GURU)', 10, '2025-11-28'),
(32, 'Восьмерка страховочная (ClimbPro)', 20, '2025-11-26'),
(33, 'Карабин муфтованный (RockMaster)', 37, '2025-11-28'),
(34, 'Тренировочный гридбол (GURU)', 5, '2025-11-27');

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
  `PhoneNumberParent` varchar(17) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Дамп данных таблицы `trainee`
--

INSERT INTO `trainee` (`Id_Trainee`, `FIO`, `Birthday`, `Section`, `Category`, `FIOParent`, `PhoneNumberParent`) VALUES
(1, 'Петров Пётр Петрович', '1999-01-01', 'Спортивный туризм', 'I юношеский спортивный разряд', 'Петров Пётр Николаевич', '+7(900)-800-48-93'),
(2, 'Иванов Иван Иванович', '2015-06-21', 'скалолазание', 'I_юношеский_спортивный_разряд', 'Иванов Иван Петрович', '+7(900)-896-42-82'),
(3, 'Артёмов Артём Артёмович', '2007-02-08', 'гребля', 'отсутствует', 'Артёмов Артём Петрович', '+7(900)-789-82-64'),
(4, 'Дмитров Дмитрий Дмитриевич', '2025-10-21', 'гребля', 'III_юношеский_спортивный_разряд', 'Дмитров Дмитрий Дмитриевич', '+7(900)-782-88-31'),
(5, 'Зубенко Михаил Петрович', '2011-01-27', 'Гребля', 'КМС', 'Зубенко Пётр Александрович', '+7(900)-900-78-78'),
(6, 'Петров Павел Сергеевич', '2008-03-15', 'Спортивный_туризм', 'II_юношеский_разряд', 'Петров Сергей Алексеевич', '+7(900)123-45-67'),
(7, 'Орлова Анна Сергеевна', '2010-09-22', 'Скалолазание', 'I_юношеский_разряд', 'Орлова Ольга Петровна', '+7(900)234-56-78'),
(8, 'Новиков Дмитрий Игоревич', '2007-11-30', 'Спортивный_туризм', 'отсутствует', 'Новиков Игорь Дмитриевич', '+7(900)345-67-89'),
(9, 'Воробьева Елена Викторовна', '2012-07-05', 'Гребля', 'III_юношеский_разряд', 'Воробьев Виктор Сергеевич', '+7(900)456-78-90'),
(10, 'Ковалев Максим Олегович', '2009-12-18', 'Спортивный_туризм', 'КМС', 'Ковалев Олег Максимович', '+7(900)567-89-01'),
(11, 'Павлова София Романовна', '2011-02-28', 'Скалолазание', 'II_юношеский_разряд', 'Павлов Роман Ильич', '+7(900)678-90-12'),
(12, 'Федоров Артем Павлович', '2006-05-10', 'Спортивный_туризм', 'МС', 'Федоров Павел Артемович', '+7(900)789-01-23'),
(13, 'Жукова Алиса Денисовна', '2013-08-14', 'Спортивный_туризм', 'I_юношеский_разряд', 'Жуков Денис Олегович', '+7(900)890-12-34'),
(14, 'Соколов Глеб Борисович', '2008-01-03', 'Спортивный_туризм', 'отсутствует', 'Соколова Борислава Глебовна', '+7(900)901-23-45'),
(15, 'Миронова Вероника Андреевна', '2010-04-25', 'Спортивный_туризм', 'II_юношеский_разряд', 'Миронов Андрей Васильевич', '+7(900)012-34-56'),
(16, 'Тимофеев Кирилл Юрьевич', '2012-12-07', 'Скалолазание', 'III_юношеский_разряд', 'Тимофеева Юлия Кирилловна', '+7(900)112-23-34'),
(17, 'Кузнецова Полина Игоревна', '2009-06-19', 'Спортивный_туризм', 'КМС', 'Кузнецов Игорь Станиславович', '+7(900)223-34-45'),
(18, 'Белов Ярослав Святославович', '2007-11-08', 'Скалолазание', 'I_юношеский_разряд', 'Белов Святослав Ярославович', '+7(900)334-45-56'),
(19, 'Комарова Ульяна Львовна', '2014-02-12', 'Гребля', 'отсутствует', 'Комарова Лилия Львовна', '+7(900)445-56-67'),
(20, 'Данилов Егор Тимофеевич', '2008-09-27', 'Скалолазание', 'II_юношеский_разряд', 'Данилов Тимофей Егорович', '+7(900)556-67-78');

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
(1, 'Карабин (GURU)', 5, '2025-11-26 00:00:00', 1),
(2, 'Карабин (Vento)', 10, '2025-11-26 00:00:00', 3),
(3, 'Карабин (Vento)', 15, '2025-11-27 00:00:00', 4),
(4, 'Фонарь налобный (RedFox)', 2, '2025-11-28 00:00:00', 12),
(5, 'Трос буксировочный (AquaSport)', 1, '2025-11-28 00:00:00', 22),
(6, 'Рюкзак туристический (Tramp)', 3, '2025-11-28 00:00:00', 5),
(7, 'Карабин муфтованный (RockMaster)', 8, '2025-11-28 00:00:00', 33),
(8, 'Жумар (GURU)', 4, '2025-11-28 00:00:00', 31),
(9, 'Веревка основная 40м (RockMaster)', 3, '2025-11-28 00:00:00', 27),
(10, 'Коврик туристический (Tramp)', 10, '2025-11-28 00:00:00', 8),
(11, 'Гермомешок (Vento)', 12, '2025-11-28 00:00:00', 18),
(12, 'Сланцы для гребли (Vento)', 8, '2025-11-28 00:00:00', 21),
(13, 'Магнезия (RockMaster)', 25, '2025-11-28 00:00:00', 30);

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
  MODIFY `Id_instructor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `inventory`
--
ALTER TABLE `inventory`
  MODIFY `IdInventory` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT для таблицы `trainee`
--
ALTER TABLE `trainee`
  MODIFY `Id_Trainee` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `written_off_inventory`
--
ALTER TABLE `written_off_inventory`
  MODIFY `IdWrittenOff` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
