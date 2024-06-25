import React, { useState, useEffect } from 'react';
import { SafeAreaView } from "react-native-safe-area-context";
import { FlatList, Image, Modal, Text, TouchableOpacity, View } from "react-native";
import Parti_Event_Item from '../../../components/Participation_Event_Item';

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
function participation_event() {
    return (
        <SafeAreaView className='mt-5 flex-1'>
            <View className='flex justify-center items-center flex-col mt-3'>
                <Text className='text-xl text-sky-600 font-semibold'>Sự kiện tham gia</Text>
            </View>
            <FlatList
                data={data}
                renderItem={({ item }) => <Parti_Event_Item item={item} />}
            />
        </SafeAreaView>
    );
}

export default participation_event;