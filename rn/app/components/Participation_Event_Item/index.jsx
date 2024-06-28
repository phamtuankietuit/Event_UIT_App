import React from "react"
import { Text, TouchableOpacity, View, Image } from "react-native"
import { format } from "date-fns"
import logo from "../../../assets/images/Logo.png"
function Parti_Event_Item({ item, deleteItem }) {
  console.log(item);
  return (
    <TouchableOpacity
      className='mx-2 my-[5px] h-[90px] flex-row  items-center rounded-lg bg-white p-1'
      style={{
        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 2,
        },
        shadowOpacity: 0.23,
        shadowRadius: 2.62,

        elevation: 4,
      }}
    >
      <View className='text-wrap flex h-[100%] w-[25%] items-center justify-center'>
        <Image source={{ uri: item.images[0].imageUrl }} className='me-4 h-[85%] w-[85%] bg-white ' />
      </View>
      <View className='mr-3 flex-1'>
        <Text numberOfLines={2} className='mb-3 font-semibold'>
          {item.title}
        </Text>
        <Text>Thời gian {format(item.publishedDate ? item.publishedDate : item.startDate, "dd/MM/yyyy - HH:mm")}</Text>
      </View>
      {/* <TouchableOpacity className='mr-3 flex items-center justify-center'>
        <Text className='rounded-lg bg-orange-300 px-3 py-2'>Hủy</Text>
      </TouchableOpacity> */}
    </TouchableOpacity>
  )
}

export default Parti_Event_Item
