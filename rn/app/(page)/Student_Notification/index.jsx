import React, { useEffect, useState } from 'react';
import { FlatList, Text, TouchableOpacity, View } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import Notifi_Item from "../../components/Notification_Item";
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faListCheck
} from '@fortawesome/free-solid-svg-icons';
const data = [
    {
        id: "1",
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: "2",
        namePage: "CLB Làn sóng",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: false
    },
    {
        id: "3",
        namePage: "CLB Bóng đá",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 4,
        namePage: "CLB nhận thức",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 5,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 6,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: false
    },
    {
        id: 7,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 8,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: false
    },
]
export default function Student_Notification() {
    const [list, setList] = useState([])
    const [day, setDay] = useState(new Date())
    useEffect(() => {
        setList(data)
    }, []);

    const setRead = async () => {
        let newList = list

        newList.map((item, index) => {
            newList[index].read = true
        })
        setList(newList)
        setDay(new Date())
    }
    useEffect(() => {

    }, [day]);
    return (
        <SafeAreaView className='flex-1'>
            <View className="flex flex-row justify-between items-center mb-3 mx-1 " >
                <Text className='text-[17px] font-bold px-2'>Mới</Text>
                <TouchableOpacity onPress={() => setRead()}>
                    <View className='flex flex-row justify-between items-center '>
                        <FontAwesomeIcon icon={faListCheck} />
                        <Text className='mx-2'>Đánh giấu đã đọc</Text>
                    </View>
                </TouchableOpacity>


            </View>
            <FlatList
                data={list}
                renderItem={({ item }) => <Notifi_Item item={item} />}
            />


        </SafeAreaView>
    );
}
