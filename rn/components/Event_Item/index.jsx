import React from 'react';
import { Text, TouchableOpacity, View, Image } from "react-native"
import { format } from 'date-fns';
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faTrash
} from '@fortawesome/free-solid-svg-icons';
function Event_Item({
    item,
    deleteItem
}) {
    return (
        <View className='flex flex-row p-1 mx-2 border shadow-xl border-slate-400  rounded-lg my-2 h-[90px]'>
            <View className="h-[100%] text-wrap w-[25%] flex items-center justify-center">
                <Image
                    source={logo}
                    className="bg-white w-[85%] h-[85%] me-4 "
                />
            </View>
            <View className='flex-1 mr-3'>
                <Text numberOfLines={2} className='font-semibold mb-3'>
                    Seminar nghiên cứu khoa học về AI cùng UIT, hãy tham gia để có các phần quà thú vị
                </Text>
                <Text>
                    Thời gian {format(new Date(), 'dd/MM/yyyy - HH:mm')}
                </Text>
            </View>
            <TouchableOpacity className='flex justify-center items-center mr-1'>
                <View className='bg-red-400 py-2 px-3 rounded-lg'>
                    <FontAwesomeIcon icon={faTrash} />
                </View>
            </TouchableOpacity>
        </View>
    );
}

export default Event_Item;